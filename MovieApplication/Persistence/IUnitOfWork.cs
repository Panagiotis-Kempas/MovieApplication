﻿using MovieApplication.Persistence.IRepositories;

namespace MovieApplication.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IActorRepository Actors { get; }
        
        int Complete();

        
    }
}
