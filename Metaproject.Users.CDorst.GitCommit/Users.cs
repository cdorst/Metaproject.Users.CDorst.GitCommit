using DevOps.VersionControl.Structures.GitCommitUser;

namespace Metaproject.Users.CDorst.GitCommit
{
    public static class Users
    {
        private const string Email = "chris@dorst.email";
        private const string Name = "Christopher Dorst";

        public static UserInfo CDorst = new UserInfo(Email, Name);
    }
}
