// goal is to create a container for all these services
// and pass that container around?

	var service = Activator.CreateInstance(typeof(HelloService)) as HelloService;
    var consumer = Activator.CreateInstance(typeof(ServiceConsumer), service) as ServiceConsumer;
    service.Print();
	consumer.Print();
	
	
//https://www.youtube.com/watch?v=NkTF_6IQPiY&t=4s

public class HelloService
{
    public void Print() => Console.WriteLine("Hello World");
}

public class ServiceConsumer
{
    private readonly HelloService _hs;
    public ServiceConsumer(HelloService hs) => this._hs = hs;

    public void Print() => _hs.Print();

}
