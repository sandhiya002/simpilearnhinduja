using System;
using System.IO;
namespace hlf{
 public class rainbow{
        public static void Main(){
     Console.WriteLine("enter a choice(new one or already existing one)");
     string ischeck=Console.ReadLine();          
        int temp=1; 
        int count=0; 
    while(temp==1){
       
       Console.WriteLine("enter a choice(1-store,2-retrieve,3-update,4-exit)");
       int ins=Convert.ToInt32(Console.ReadLine());
      if(ins==1){
        if(ischeck=="new one"&& count==0){
         count++;
                using( StreamWriter sw=File.AppendText(@"C:\\Users\\22629\\sandhiyac\\stack\\projects\\rainbowschool.txt"))
         {  
         Console.WriteLine("id");
         int x=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("name");
         string y=Console.ReadLine();
         Console.WriteLine("class&section");
         string z=Console.ReadLine();
         sw.WriteLine("id|name|class&section");
         sw.WriteLine("{0}|{1}|{2}",x,y,z);
         sw.WriteLine(" ");
        }
        }
      else
      {
          using( StreamWriter sw=File.AppendText(@"C:\\Users\\22629\\sandhiyac\\stack\\projects\\rainbowschool.txt"))
       {  
         Console.WriteLine("id");
         int x=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("name");
        string y=Console.ReadLine();
        Console.WriteLine("class&section");
        string z=Console.ReadLine();
        sw.WriteLine("{0}|{1}|{2}",x,y,z);
        sw.WriteLine(" ");
        }
      }
      }
       else{
          if(ins==2){
             using( StreamReader sr=File.OpenText(@"C:\\Users\\22629\\sandhiyac\\stack\\projects\\rainbowschool.txt"))
        {
          string data=null;
            while((data=sr.ReadLine())!=null)
           {
           System.Console.WriteLine("{0}",data);
           }       
        }
                   }
        else
          if(ins==3){
             using( StreamWriter sw=File.AppendText(@"C:\\Users\\22629\\sandhiyac\\stack\\projects\\rainbowschool.txt"))
            {  
             Console.WriteLine("id");
             int x=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("name");
             string y=Console.ReadLine();
             Console.WriteLine("class&section");
             string z=Console.ReadLine();
             sw.WriteLine("{0}|{1}|{2}",x,y,z);
             sw.WriteLine(" ");
             sw.Close();
           }
         using( StreamReader sr=File.OpenText(@"C:\\Users\\22629\\sandhiyac\\stack\\projects\\rainbowschool.txt"))
           {
          string data=null;
            while((data=sr.ReadLine())!=null)
                     System.Console.WriteLine("{0}",data);   
            }
              Console.WriteLine("Updated Successfully");
          }
           else{
                 temp=0;
                 Console.WriteLine("EXIT..........");
            }
        }
      }
    }
 }
}
