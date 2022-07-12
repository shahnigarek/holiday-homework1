using System;
namespace ConsoleApp7
{ class Program
    {
    static void Main(string[] args)
    {
            string word = "basic";
            

    ProDocumentProgram pro = new ProDocumentProgram();

    ExpertDocumentProgram expert = new ExpertDocumentProgram();

    DocumentProgram basic = new DocumentProgram();
        
            if(word=="basic")
            {
                basic.EditDocument();
                basic.OpenDocument();
                basic.SaveDocument();
            }
            else if (word == "pro")
            {
                pro.EditDocument();
                pro.OpenDocument(); 
                pro.SaveDocument();

            }
            else if (word =="expert" )
            {
                expert.EditDocument();  
                expert.OpenDocument();
                  expert.SaveDocument();    
            }
            else
                Console.WriteLine("not found");
    }
        


    }

    



}






