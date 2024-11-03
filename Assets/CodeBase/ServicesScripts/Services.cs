using System;

namespace Assets.Scripts.ServicesScripts
{
    public class Services
    {
        public static Services Containervnfmtk => _containerdktlyo ?? (_containerdktlyo = new Services());    
        private static Services _containerdktlyo;

        public TService Registeraeortyt<TService>(TService service) where TService : IService
        {
            Implementation<TService>.ServiceInstancekdorly = service;
            return Implementation<TService>.ServiceInstancekdorly;
        }

        public TService Geteorpto<TService>() where TService : IService =>
            Implementation<TService>.ServiceInstancekdorly;


        private static class Implementation<TService> where TService : IService
        {
            public static TService ServiceInstancekdorly;
        }
    }
}
