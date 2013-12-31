﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Swapsha.Api.Features.Reviews.Models;

public record GetReviewsResponse(
    short TotalReviews,
    double AverageRating,
    List<GetReviewsReview> Reviews);

public record GetReviewsReview(
    byte Rating,
    string DateCreated,
    string PostedById);

public record PostReviewRequest
{
    [Required(ErrorMessage = "Rating is required.")]
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int Rating { get; set; }

    [Required(ErrorMessage = "UserId is required.")]
    public string UserId { get; set; }
}