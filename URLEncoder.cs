using System;
namespace URLEncoder
{
	class Program
	{//main args
		static bool flag = false;
		static void Main(string[]args)
		{
			do
			{//make strings//
				string project_name="";
				string activity_name="";
				try
				{//get names//
					Console.WriteLine("\nEnter project name:");
					project_name=Console.ReadLine();
					Console.WriteLine("Enter activity name:");
					activity_name=Console.ReadLine();
				//write URL and swap characters//
					string URL = "https://companyserver.com/content/"+project%20name+"/files"+activity%20name+"/"+activity%3Ename+"Report.pdf";
					Console.WriteLine("\n");
					Console.WriteLine(URL);
				}
				//Catch input//
				catch
				{
					Console.WriteLine("Enter valid input.");
					
				}
				//prompt for another//
				Console.WriteLine("\n");
				Console.WriteLine("Would you like to do another? (y/n):")
				char again = Convert.ToChar(Console.ReadLine());
				if(again=='y')
				{
					flag = true;
				}
			} while(flag==true);
		}//loop back to start//
	}
}