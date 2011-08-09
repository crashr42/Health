using System;
using System.Web.Mvc;
using System.Web.Routing;
using Health.API;

namespace Health.Site.Filters
{
    public class AuthFilter : IAuthorizationFilter
    {
        /// <summary>
        /// ���� ������������ ���� �������� ������
        /// </summary>
        protected readonly RedirectToRouteResult RedirectResult = new RedirectToRouteResult(
            new RouteValueDictionary(new {area = "Account", controller = "Authorization", action = "Login"}));

        /// <summary>
        /// ����������� ���� (��������� ����, ��� � DenyRoles)
        /// </summary>
        public string AllowRoles;

        /// <summary>
        /// ����������� ����
        /// </summary>
        public string DenyRoles;

        private string _userRole;

        public AuthFilter(ICoreKernel core_kernel, string allow_roles, string deny_roles)
        {
            CoreKernel = core_kernel;
            AllowRoles = allow_roles;
            DenyRoles = deny_roles;
        }

        /// <summary>
        /// ���� ������������
        /// </summary>
        private string UserRole
        {
            get
            {
                if (String.IsNullOrEmpty(_userRole))
                {
                    _userRole = CoreKernel.AuthServ.UserCredential.Role;
                }
                return _userRole;
            }
        }

        /// <summary>
        /// ����������� ������
        /// </summary>
        protected ICoreKernel CoreKernel { get; set; }

        #region IAuthorizationFilter Members

        public void OnAuthorization(AuthorizationContext filter_context)
        {
            // ���� � ������������ ������ ��� ���� (������� ?)
            if (String.IsNullOrEmpty(CoreKernel.AuthServ.UserCredential.Role))
            {
                // ���������� ��� ������ �� �����
                CoreKernel.AuthServ.Logout();
            }

            // ���� �� ������ ����� �������
            if (String.IsNullOrEmpty(AllowRoles) & String.IsNullOrEmpty(DenyRoles))
            {
                // ������� ��� ���� �������������� ������������� �������� ������
                if (!CoreKernel.AuthServ.UserCredential.IsAuthirization)
                {
                    filter_context.Result = RedirectResult;
                    return;
                }
            }

            // ���� ������� ������ ����� �� ������ �������
            if (String.IsNullOrEmpty(AllowRoles) & !String.IsNullOrEmpty(DenyRoles))
            {
                filter_context.Result = OnlyDenyPermission(filter_context.Result);
                return;
            }

            // ���� ������� ����� ������ �� ���������� �������
            if (!String.IsNullOrEmpty(AllowRoles) & String.IsNullOrEmpty(DenyRoles))
            {
                filter_context.Result = OnlyAllowPermission(filter_context.Result);
                return;
            }


            if (!String.IsNullOrEmpty(AllowRoles) & !String.IsNullOrEmpty(DenyRoles))
            {
                filter_context.Result = OnlyDenyPermission(filter_context.Result);
                filter_context.Result = OnlyAllowPermission(filter_context.Result);
            }
        }

        #endregion

        /// <summary>
        /// ���� ������ ���� ����������� ����������
        /// </summary>
        /// <param name="default">��������� �������� � ����������� ��-���������</param>
        /// <returns>��������� �������� � �����������</returns>
        private ActionResult OnlyDenyPermission(ActionResult @default)
        {
            string[] roles = DenyRoles.Split(',');

            foreach (string role in roles)
            {
                if (role == UserRole || role == CoreKernel.AuthServ.DefaultRoles.All.Name)
                {
                    return RedirectResult;
                }
            }

            return @default;
        }

        /// <summary>
        /// ���� ������ ���� ����������� ����������
        /// </summary>
        /// <param name="default">��������� �������� � ����������� ��-���������</param>
        /// <returns>��������� �������� � �����������</returns>
        private ActionResult OnlyAllowPermission(ActionResult @default)
        {
            string[] roles = AllowRoles.Split(',');

            foreach (string role in roles)
            {
                if (role == UserRole)
                {
                    return @default;
                }
            }
            return RedirectResult;
        }
    }
}