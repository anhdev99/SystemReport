using System;
using System.Collections.Generic;
using System.Linq;

namespace SystemReport.WebAPI.Params
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;

        private PagedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber + 1;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }
        public static PagedList<T> ToPagedList(IQueryable source, int pageNumber, int pageSize)
        {
            // var count = source.Count();
            // var items = source.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            // return new PagedList<T>(items, count, pageNumber, pageSize);
            return null;
        }
    }
}