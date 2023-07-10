using System;

namespace TemplateMethodPattern
{
    
    class Program
    {
        static void Main(string[] args)
        {
            BuildProject biuldP = new BuildProject();
            Console.WriteLine("\n after override updated templates : \n");
            BuildProject newtemplate = new BuildProjectOnStaging();
            Console.ReadLine();  
        }
    }


    class BuildProject
    {

        public BuildProject(){
            CompileCode();
            RunTest();
            DeployCode();
        }
        

    //   creating all default initialized template methods:
        public virtual void CompileCode()
        {
            Console.WriteLine(" first code is compiled!");
        }

        public virtual void RunTest()
        {
            Console.WriteLine("default template running");
        }

        public virtual void DeployCode()
        {
            Console.WriteLine("first template is deplyed!");
        }
   
    }//end BuildProject class




    //here is derive class from BuildProject class
    class BuildProjectOnStaging: BuildProject
    {
        public BuildProjectOnStaging():base()
        {} // here is called base constructor

        public override void CompileCode()
        {
           Console.WriteLine("updated compiled code");
        }
        public override void RunTest()
        {
            Console.WriteLine("updated Run test code");
        }
        public override void DeployCode()
        {
            Console.WriteLine("updated deplyed server");
        }
    }//end BuildProjectOnStaging class

}
