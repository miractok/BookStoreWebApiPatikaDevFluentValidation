using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperations.GetById
{
    public class GetByIdQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int BookID { get; set; }
        public GetByIdQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public BooksViewIdModel Handle()
        {
            var book = _dbContext.Books.Where(book=> book.Id == BookID).SingleOrDefault();
            if(book == null)
                throw new InvalidOperationException("Girdiğiniz Id hiçbir kitapla eşleşmemektedir.");
            BooksViewIdModel vm = _mapper.Map<BooksViewIdModel>(book); 
            return vm;
        }
    }

    public class BooksViewIdModel
    {
        public string? Title { get; set; }

        public string? Genre { get; set; }

        public int PageCount { get; set; }

        public string? PublishDate { get; set; }
    }
}