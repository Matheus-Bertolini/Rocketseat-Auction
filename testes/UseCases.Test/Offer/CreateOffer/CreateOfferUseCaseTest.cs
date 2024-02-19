using Bogus;
using FluentAssertions;
using Moq;
using RocketseatAuction.API.Communication.Requests;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Services;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;
using RocketseatAuction.API.UseCases.Offers.CreateOffer;
using Xunit;

namespace UseCases.Test.Offer.CreateOffer;
internal class CreateOfferUseCaseTest
{
    [Fact]
    public void Success()
    {
        //ARRANGE
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(request => request.Price, f => f.Random.Decimal(1, 10)).Generate();

        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<LoggedUser>();
        loggedUser.Setup(i = i.User()).Returns(new User()) 

        var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

        //ACT
        var act = () => useCase.Execute(0, request);

        //ASSERT
        act.Should().NotThrow()
    }
}
