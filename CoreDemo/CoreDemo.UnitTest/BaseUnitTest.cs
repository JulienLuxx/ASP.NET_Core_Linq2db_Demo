using AutoMapper;
using CoreDemo.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace CoreDemo.UnitTest
{
    public abstract class BaseUnitTest
    {
        protected ServiceCollection _serviceCollection { get; set; }

        protected ServiceProvider _serviceProvider { get; set; }

        protected BaseUnitTest()
        {
            _serviceCollection = new ServiceCollection();
            _serviceCollection.AddAutoMapper(typeof(CustomizeProfile));
        }

        protected void BuilderServiceProvider()
        {
            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }
    }
}
