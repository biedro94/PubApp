using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Service;
using BaseRepository.Repository.Implementation;


namespace DependencyResolver
{
    public class DependencyResolver
    {
        public static IService Get()
        {
            var _service = new Repository();
            return new Service(_service);
        }
    }
}