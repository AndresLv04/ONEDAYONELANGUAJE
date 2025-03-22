using System;
using System.Threading;
namespace ProducerConsumerThreads
{
    public class Program {
	    static void Main(String[] args) {

		
		    Store objAlmacen = new Store(10);

		    for (int i = 1; i < 5; i++) {
			    new Thread(new Producer(objAlmacen, "Hilo " + i)).start();
		    }

		    for (int i = 1; i < 5; i++) {
			    new Thread(new Consumer(objAlmacen, "Hilo " + i)).start();
		    }
	    }
    }
}