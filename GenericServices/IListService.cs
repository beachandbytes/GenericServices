﻿using System.Linq;
using GenericServices.Concrete;

namespace GenericServices
{
    public interface IListService<out TData> where TData : class
    {
        /// <summary>
        /// This returns an IQueryable list of all items of the given type
        /// </summary>
        /// <returns>note: items are not tracked</returns>
        IQueryable<TData> GetList();
    }

    public interface IListService<TData, out TDto>
        where TData : class
        where TDto : EfGenericDto<TData, TDto>, new()
    {
        IQueryable<TDto> GetList();
    }
}