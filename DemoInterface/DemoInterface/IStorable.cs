using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public interface IStorable
    {
        void Read(String fileName);
        void Write(String fileName);
    }
}
