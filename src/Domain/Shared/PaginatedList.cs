using Microsoft.EntityFrameworkCore;

namespace Domain.Shared
{
    public class PaginatedList<T>
    {
        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            Items = items;
            TotalCount = count;
            PageIndex = pageIndex;
            PageSize = pageSize;
        }

        public List<T> Items { get; }
        public int TotalCount { get; }
        public int PageIndex { get; }
        public int PageSize { get; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;


        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }

        public static PaginatedList<T> Create(IEnumerable<T> source, int pageIndex,
            int pageSize)
        {
            var enumerable = source.ToList();
            var count = enumerable.Count();
            return new PaginatedList<T>(enumerable.ToList(), count, pageIndex, pageSize);
        }
    }
}