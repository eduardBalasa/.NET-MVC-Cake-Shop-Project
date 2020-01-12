using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CakeShop.BindingModels;
using CakeShop.Models;
using CakeShop.Repositories.Interfaces;
using CakeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CakeShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;

        public ReviewController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        // POST: api/Review
        [HttpPost]
        public async Task<ActionResult> PostReview(ReviewBindingModel reviewBindingModel)
        {
            var review = _mapper.Map<Review>(reviewBindingModel);
            review.Date = DateTime.Now;

            _repositoryWrapper.ReviewRepository.Create(review);
            _repositoryWrapper.Save();

            return Ok();
        }

        // GET: api/Review
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ReviewViewModel>>> GetReviews(int id)
        {
            var reviews = await _repositoryWrapper.ReviewRepository.FindByCondition(r => r.CakeId == id).ToListAsync();
            var reviewsViewModels = _mapper.Map<List<ReviewViewModel>>(reviews);
            return reviewsViewModels;
        }

    }
}