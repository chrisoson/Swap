﻿using System.Net;
using Swapsha.Api.Data.Seed;
using Swapsha.Api.Tests.Fixtures;

namespace Swapsha.Api.Tests.IntegrationTests.Controllers.Users;

[Collection("TestCollection")]
public class GetNamesTests(ApiFactory factory) : BaseTest(factory)
{
    [Fact]
    public async Task OK_When_Getting_Names()
    {
        // Arrange
        var validUser = await GetValidUser(_client);

        // Act
        var response = await _client.GetAsync($"/api/v1/users/{validUser.UserId}/names");

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task NotFound_When_RouteId_Is_Not_UserId()
    {
        var response = await _client.GetAsync($"/api/v1/users/546489/names");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => _resetDatabase();
}