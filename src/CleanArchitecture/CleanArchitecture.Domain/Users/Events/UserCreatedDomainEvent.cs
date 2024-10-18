using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Reviews;

namespace CleanArchitecture.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(UserId UserId) : IDomainEvent;