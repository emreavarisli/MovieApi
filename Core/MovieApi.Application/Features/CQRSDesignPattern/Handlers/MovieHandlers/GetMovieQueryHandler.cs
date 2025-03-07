using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetMovieQueryResults>> Handle()
        {
            var values = await _context.Movies.ToListAsync();
            return values.Select(x => new GetMovieQueryResults
            {
                MovieId =x.MovieId,
                CoverImageUrl = x.CoverImageUrl,
                Rating = x.Rating,
                CreatedYear = x.CreatedYear,
                Description = x.Description,
                Duration = x.Duration,
                ReleaseDate = x.ReleaseDate,
                Status = x.Status,
                Title = x.Title
            }).ToList();
        }
    }
}
