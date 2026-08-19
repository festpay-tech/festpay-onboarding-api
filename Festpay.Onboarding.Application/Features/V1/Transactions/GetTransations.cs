using Carter;
using Festpay.Onboarding.Application.Common.Constants;
using Festpay.Onboarding.Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festpay.Onboarding.Application.Features.V1.Transactions;
public class GetTransations
{

}
public sealed class GetTransationsEndpoint :ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet($"{EndpointConstants.V1}{EndpointConstants.Transacao}",
            async ([FromServices] ISender sender) =>
            {
                var result = await sender.Send(new GetAccountsQuery( ));
                return Result.Ok(result);
            }
        )
        .WithTags(SwaggerTagsConstants.Transaction);
    }
}