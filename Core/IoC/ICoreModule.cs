using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IoC
{
    //Core gördüğümüzde framework katmanımız. TÜm projelerimizde içeren yapı
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
