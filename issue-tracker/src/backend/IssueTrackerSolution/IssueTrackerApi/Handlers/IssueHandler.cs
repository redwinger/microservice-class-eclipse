using IssueTrackerApi.Data;
using Wolverine;

namespace IssueTrackerApi.Handlers;

public class IssueHandler(IMessageBus bus, IssuesDataContext context)
{
    public async Task Handle(PublishIssueCommand command)
    {
        var @event = new IssueCreated()
    }
}
