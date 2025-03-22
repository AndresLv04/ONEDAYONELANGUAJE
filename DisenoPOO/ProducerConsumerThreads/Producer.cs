
namespace ProducerConsumerThreads{
    public class Producer : Thread {

        private Store Store;
        private String Name;
        private Ramdom ramdom;

        public Producer(Store store, String name) {
            this.Store = store;
            this.Name = name;
            this.ramdom = Ramdom.
        }

        @Override
        public void run() {
            int NumProducts = 0;

            while (true) {
                
                NumProducts = ramdom.Next(5);
                
                this.Store.Produce(NumProducts, Name);
                
                try {
                    Thread.sleep(3000);
                } catch (InterruptedException e) {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}