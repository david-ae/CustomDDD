﻿using MediatR;

namespace CustomDDD.API.Queries
{
    public record GetPupilByIdQuery(int Id) : IRequest<Pupil>;
}