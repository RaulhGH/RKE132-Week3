Console.WriteLine("Enter number");
int userNum = Convert.ToInt32(Console.ReadLine());

//paaris või paritu

int result = userNum % 2;


if(result!=0) //!= - ei ole
{
    Console.WriteLine("User numner is odd");    
}
else
{
    Console.WriteLine("is even");
}


