using System;
using Rentler.Admin.Common;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin
{
    public interface IUserAdapter
    {
        /*Status<PaginatedList<Common.UserPreview>> SearchUsers(string search, string order, int pageNumber, int pageSize);
        Status<Common.User> GetUserDetails(int userId);
        Status<PagedList<Common.BuildingPreview>> GetUserBuildings(
            int userId, string filter, string search, int pageNumber, int pageSize);
        Status<PagedList<Common.CommunityDetails>> GetUserCommunities(
            int userId, string filter, string search, int pageNumber, int pageSize);
        Status<Role[]> GetRolesUserNotAPartOf(Common.User user);
        Status<Common.User> AddUserToRole(int userId, string roleName);
        Status<Common.User> RemoveUserFromRole(int userId, string roleName);
        Status<IEnumerable<Common.Role>> GetUserRoles();
        Status<int> ResetIdVerifyCount(int userId);
        Status<int?> SetRefreshDays(int userId, int? days);
        Status<AccountUpgradeDetail> UpgradeUserAccount(int userId, string InvoiceContactName, string InvoiceContactPhone,
            string RequestedPackage, AccountUpgradeStatus UpgradeStatus, int AdvertisedListingCount);
        Status<bool> UpdateUserPassword(int userId, string newPassword);
        Status<IEnumerable<Common.Contact>> GetContactInfoes(int userId);
        Status<Common.UserNote> AddUserNote(int userId, string content);
        Status<bool> DeleteUserNote(int userNoteId);
        //Status<IEnumerable<Common.UserNote>> GetUserNotes(int userId);        
        PagedList<Common.UserNote> ListUserNotes(int userId, int page, int pageSize);
        PagedList<Common.Transaction> ListTransactions(int userId, int page, int pageSize, string filter, string query);
        PagedList<Common.ScheduledTransaction> ListScheduledTransactions(int userId, int page, int pageSize, string filter, string query);
        Status<Common.User> UpdateUserEmail(int userId, string newEmail);*/
    }
    public class UserAdapter:IUserAdapter
    {

    }
}
