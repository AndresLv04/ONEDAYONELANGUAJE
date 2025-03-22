namespace ProducerConsumerThreads{
    public class Store {

        private int Articles;
        private readonly int NumMaxStock = 20;

        public Store(int articles) {
            this.Articles = articles;
        }

        public void Produce(int NewProducts, String Name) {
            lock (lockObj)
            {
                try
                {
                    while ((NewProducts + this.Articles) > NumMaxStock)
                    {
                        Monitor.Wait(lockObj);
                    }
                    this.Articles = this.Articles + NewProducts;
                    Console.WriteLine($"El Productor {Name} ha conseguido añadir {NewProducts} productos. Stock = {this.Articles}");
                    Monitor.PulseAll(lockObj);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void Consume(int ProductstoRemove, String Name) {
            lock (lockObj)
            {
                try
                {
                    while ((this.Articles - ProductstoRemove) < 0)
                    {
                        Monitor.Wait(lockObj);
                    }
                    this.Articles = this.Articles - ProductstoRemove;
                    Console.WriteLine($"El Consumidor {Name} ha retirado {ProductstoRemove} productos. Stock = {this.Articles}");
                    Monitor.PulseAll(lockObj);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public int GetArticles() {
            return Articles;
        }
    }
}