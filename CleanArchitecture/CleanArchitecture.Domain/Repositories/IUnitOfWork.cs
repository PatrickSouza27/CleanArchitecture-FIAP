﻿namespace CleanArchitecture.Domain.Repositories;

public interface IUnitOfWork
{
    Task Commit(CancellationToken cancellationToken = default);
}