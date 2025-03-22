
namespace ProducerConsumerThreads{
    public class Consumer : Thread {

        private Store Store;
        private String Name;
        private Ramdom ramdom;

        public Consumer(Store store, String name) {
            this.Store = store;
            this.Name = name;
            ramdom = new Ramdom();
        }

        @Override
        public void run() {
            int NumProducts = 0;

            while (true) {
                
                NumProducts = ramdom(1,6);
                
                this.Store.Consume(NumProducts, Name);
                
                try {
                    Thread.sleep(3000);
                } catch (InterruptedException e) {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}