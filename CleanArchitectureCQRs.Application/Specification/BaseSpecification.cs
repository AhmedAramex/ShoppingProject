﻿using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Domain.Abstractions;
using System.Linq.Expressions;

namespace CleanArchitectureCQRs.Application.Specification;

public class BaseSpecification<T> : ISpecification<T> where T : BaseEntity
{
    public Expression<Func<T, bool>> Criteria { get; set; }

    public BaseSpecification(Expression<Func<T, bool>> WhereExpresssion)
    {
        Criteria = WhereExpresssion;
    }
    public BaseSpecification()
    {

    }



}
