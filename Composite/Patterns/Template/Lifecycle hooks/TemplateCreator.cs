using Composite.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.Template.Lifecycle_hooks
{
    public abstract class TemplateCreator
    {
        public LightNode? CreateNode(string type) 
        {
            LightNode? node;
            this.OnCreated();
            if (type == "text")
            {
                Console.WriteLine("Text = ");
                string text = Console.ReadLine();
                node = new LightTextNode(text);
            }
            else if (type == "tag")
            {
                /*Console.WriteLine("Name = ");
                string tagName = Console.ReadLine();*/
                string tagName = "div";
                /*Console.WriteLine("tagType(0/1) = ");
                byte tagType = Convert.ToByte(Console.ReadLine());*/
                byte tagType = 1;
                /*Console.WriteLine("tagCloseType(0/1) = ");
                byte tagCloseType = Convert.ToByte(Console.ReadLine());*/
                byte tagCloseType = 1;
                node = new LightElementNode(tagName,tagType,tagCloseType);
            }
            else node = null;
            this.OnEndCreating();
            return node;
        }
        public virtual void OnCreated()
        { 
        }
        public virtual void OnEndCreating()
        {
        }
    }
}
