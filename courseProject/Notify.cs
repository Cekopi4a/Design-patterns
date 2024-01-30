using courseProject.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
    //OBSERVE PATTERN 
    public class Notify
    {
        //Creating ArrayList for the messages
        public ArrayList MessNotify = new ArrayList();

        //Adding a massage
        public void AddService(ICarFactory msg)
        {
            MessNotify.Add(msg);
        }

        //Remove a message
        public void RemoveService(ICarFactory msg)
        {
            MessNotify.Remove(msg);
        }

        //Method that call the messages
        public void ExecuteService()
        {
            foreach (ICarFactory msg in MessNotify)
            {
                msg.Notify();
            }
        }
    }
}
