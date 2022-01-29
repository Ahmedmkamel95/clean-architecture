using clean_architecture.Domain.Common;

namespace clean_architecture.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
