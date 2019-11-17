using Pixiv.Clients.V1.User;

namespace Pixiv.Clients.V1
{
    public class UserClient : ApiClient
    {
        public BookmarksClient Bookmarks { get; }
        public BookmarkTagsClient BookmarkTags { get; }
        public BrowsingHistoryClient BrowsingHistory { get; }
        public FollowClient Follow { get; }
        public MeClient Me { get; }
        public ProfileClient Profile { get; }
        public WorkspaceClient Workspace { get; }

        internal UserClient(PixivClient client) : base(client, "/v1/user")
        {
            Bookmarks = new BookmarksClient(client);
            BookmarkTags = new BookmarkTagsClient(client);
            BrowsingHistory = new BrowsingHistoryClient(client);
            Follow = new FollowClient(client);
            Me = new MeClient(client);
            Profile = new ProfileClient(client);
            Workspace = new WorkspaceClient(client);
        }
    }
}