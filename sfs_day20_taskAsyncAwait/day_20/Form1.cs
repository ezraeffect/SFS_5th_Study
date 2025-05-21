using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

/*
 * Task
 * - 비동기 작업을 나타내는 Type(Class)
 * Task : 결과가 없는 작업 | void
 * Task<T> : 결과가 있는 작업 | Task<int> => int 반환 역할
 * 
 * Async
 * - 해당 메서드가 "비동기 작업을 수행함"을 컴파일러에게 알리는 키워드
 * - 메서드 안에서 await을 사용할 수 있게 해줌
 * 
 * Await
 * - 해당 비동기 작업(Task)가 끝날 때까지 기다림
 * - 기다리면서도 스레드를 점유하지 않기 떄문에 UI 멈춤 없이 동작한다
 * - Task 또는 Task<T>를 반환하는 메서드에만 붙일 수 있음
 * 
 * When
 * - 시간이 오래 걸리는 작업에서 UI를 멈추면 안될 떄
 * ㄴ Thread.Sleep -> UI 프리징
 * - I/O 작업 (파일, DB, 웹 요청 등) 처리할 때
 * - 여러 작업을 동시에 처리하고 싶을 때
 */

/*
 * Thread
 * - 직접 스레드를 생성해서 병렬 작업 가능
 * - UI Thread와 분리되므로 UI 멈춤 방지는 가능
 * - UI 변경시 Invoke 필요, 코드 복잡함
 * - 비동기 처리 불가 (작업이 끝날 때까지 스레드 점유)
 * 
 * BackgroundWorker
 * - 이벤트 기반으로 동작하는 구형 멀티스레딩 방식 (WinForm 초기 방식)
 * - UI 연동 위해 따로 RunWorkerCmpleted 필요
 * - async/await 도입 이후 거의 사용되지 않음 -> Legacy Project로만 관리됨
 *
 * Task + async/await
 * - 가장 현대적이고 권장되는 비동기 처리 방식
 * - 코드 간결, UI 멈춤 없음, 가독성 높음
 * - 예외 처리 간편 (try-catch 가능)
 */

/*
 * [Method]
 * Task.Run
 * - 병렬 작업
 * Task.Delay
 * - 지연 작업
 * Task.WhenAll
 * - 병렬 대기
 * Task.FromResult
 * - 결과 Task 래핑
 */
/*
* -Task는 C#에서 비동기 작업을 나타내는 객체
* - 작업이 진행중이고 나중에 완료된다
* Task 또는 Task<T>, await 가능한 객체를 반환하는 메서드에만 붙일 수 있음.
*/
namespace day_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Button Click Event Handler
        /* async?
         * 해당 메서드가 비동기 작업을 포함한다 선언
         * async를 붙이면 await을 쓸 수 있게 됨.
         * 단독 기능 없으며, 반드시 await과 함께 사용해야함
         */

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "작업 시작";

            // 2. Task.Run()으로 백그라운드에서 무거운 작업 실행.
            await Task.Run(() => LongWork());

            label1.Text = "작업 종료";
        }

        // 2-1. 무거운 작업 Method (실제로는 CPU를 점유함)
        private void LongWork()
        {
            Thread.Sleep(3000); // CPU 점유함.
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "4초 대기 중 ...";

            // 2. Task.Run()으로 백그라운드에서 무거운 작업 실행.
            await Task.Delay(4000); // Delay가 끝날 때까지 기다려라

            label1.Text = "4초 대기 완료";
        }

        // Task.FromResult
        // - 이미 계산된 결과를 Task를 감싸서 반환할 때 사용
        private async void button3_Click(object sender, EventArgs e)
        {
            Task<int> task = Task.FromResult(123); // 즉시 완료된 Task 객체

            int result = await task;

            //label1.Text = $"결과 : {result}";
            label1.Text = $"결과 : {task}";
        }

        // Task.WhenAll
        // - 여러 Task를 동시에 실행하고, 모두 끝날 때까지 기다림.
        private async void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "모든 작업 시작";

            Task t1 = Task.Run(() => Thread.Sleep(2000)); // 스레드에서 2초
            Task t2 = Task.Delay(3000); // 3초 대기 (비동기)

            // 제일 오래 걸리는 Task가 끝날때까지 대기
            await Task.WhenAll(t1, t2);

            
            label1.Text = "모든 작업 종료";
        }

        public async Task<int> Add(int a, int b)
        {
            return a + b;
        }

        /*
         * int를 반환
         * -> await은 비동기 결과 (Task)가 필요
         * 
         * async Task<int> 작업한 메서드는
         * -> Task<int> 반환
         */


    }
}
