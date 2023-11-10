using System;
using static Interfaces.Elettronic;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mascheriamo elettronic da Iphone
            Elettronic elettronic = new Iphone();            
        }
    }

    interface ITelefone
    {
        public void Call();
    }

    interface IsmartPhone: ITelefone,ImediaPlayer
    {
        public string Nseriale { get; set; }
        public void Camera();
        public void GPS();
    }

    interface ImediaPlayer 
    {
        public void Play(); 
        public void Pause();
        public void Stop();
    }

    abstract public class Elettronic
    {
        public string _nSeriale;
    }   
     public class Iphone:Elettronic, IsmartPhone
            
     {
            public string Nseriale { get; set; }

            public void Call() {}
            public void Play() {}
            public void Pause() {}
            public void Stop() {}
            public void Camera() { }
            public void GPS() { }
     }
        
        
}

