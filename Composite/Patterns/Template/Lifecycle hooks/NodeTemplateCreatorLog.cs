using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Patterns.Template.Lifecycle_hooks
{
    public class NodeTemplateCreatorLog : TemplateCreator
    {
        public override void OnCreated()
        {
            Console.WriteLine("Node creating...");
        }
        public override void OnEndCreating()
        {
            Console.WriteLine("End of node creating 100%)");
        }
    }
}
