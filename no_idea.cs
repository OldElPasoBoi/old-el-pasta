using static System.Console;

namespace Message
{
	class Hello
	{
		public string message = "Hello, world";
		public Hello()
		{
			WriteLine(message);
		}
	}
}

static void Main()
{
	Hello helloMessage = new Hello();
	helloMessage.Hello();
}
