using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Service
{
    public abstract class BaseSvc
    {
        protected IMapper _mapper;

        protected BaseSvc()
        { }
    }
}
