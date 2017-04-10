﻿using System;

namespace AspectCore.Abstractions
{
    [NonAspect]
    public abstract class AspectContext : IDisposable
    {
        public virtual IServiceProvider ServiceProvider { get; }

        public virtual TargetDescriptor Target { get; }

        public virtual ProxyDescriptor Proxy { get; }

        public virtual ParameterCollection Parameters { get; }

        public virtual ParameterDescriptor ReturnParameter { get; }

        public virtual AspectDictionary Data { get; }

        protected virtual void Dispose(bool disposing)
        { 
        }

        public void Dispose()
        {   
            Dispose(true);
        }
    }
}