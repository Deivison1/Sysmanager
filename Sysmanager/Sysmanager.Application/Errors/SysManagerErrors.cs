using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Sysmanager.Application.Errors
{
    public enum SysManagerErrors
    {
        #region User
        [Description("Necessário informar a propriedade (Username)")]
        User_Post_BadRequest_UserName_Cannot_Be_Null_Or_Empty,

        [Description("Necessário informar a propriedade (Email)")]
        User_Post_BadRequest_Email_Cannot_Be_Null_Or_Empty,

        [Description("Necessário informar a propriedade (Password)")]
        User_Post_BadRequest_Password_Cannot_Be_Null_Or_Empty,

        [Description("Ja existe um usuário com essa senha e-mail")]
        User_Post_BadRequest_Email_Cannot_Be_Duplicated,

        [Description("Usuário ou e-mail inválido ou inexistente")]
        User_Put_BadRequest_User_Not_Found,
        #endregion

        #region POST Unity
        [Description("É necessário informar o nome da unidade de medida")]
        Unity_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty,

        [Description("É necessário informar se a unidade é ativa ou inativa")]
        Unity_Post_BadRequest_Active_Cannot_Be_Diferent_True_Or_False,

        [Description("Já existe uma unidade de medida com esse nome")]
        Unity_Post_BadRequest_Name_Cannot_Be_Duplicated,
        #endregion

        #region PUT Unity
        [Description("É necessário informar o id da unidade de medida")]
        Unity_Put_BadRequest_Id_Cannot_Be_Null_Or_Empty,

        [Description("É necessário informar o nome da unidade de medida")]
        Unity_Put_BadRequest_Name_Cannot_Be_Null_Or_Empty,

        [Description("É necessário informar se a unidade é ativa ou inativa")]
        Unity_Put_BadRequest_Active_Cannot_Be_Diferent_True_Or_False,

        [Description("Já existe uma unidade de medida com esse nome")]
        Unity_Put_BadRequest_Name_Cannot_Be_Duplicated,

        [Description("Unidade de medida inválida ou inexistente")]
        Unity_Put_BadRequest_Id_Is_Invalid_Or_Inexistent,
        #endregion

        #region DELETE Unity
        [Description("Unidade de medida inválida ou inexistente")]
        Unity_Delete_BadRequest_Id_Is_Invalid_Or_Inexistent,
        #endregion

        #region GET Unity
        [Description("Unidade de medida inexistente ou inválida")]
        Unity_Get_BadRequest_Id_Is_Invalid_Or_Inexistent,
       
        [Description("É necessário informar o nome da unidade de medida")]
        Unity_Get_BadRequest_Name_Cannot_Be_Null_Or_Empty,

        [Description("É necessário informar se a unidade é ativa ou inativa")]
        Unity_Get_BadRequest_Active_Cannot_Be_Empty,

        [Description("É necessário informar se a página é maior que zero")]
        Unity_Get_BadRequest_Page_More_Than_Zero,

        [Description("É necessário informar se o tamanho da página é maior que zero")]
        Unity_Get_BadRequest_pageSize_More_Than_Zero,

        #endregion

        #region POST Product

        [Description("Necessário informar a propriedade (Username)")]
        Product_Post_BadRequest_UserName_Cannot_Be_Null_Or_Empty,

        [Description("Necessário informar a propriedade (Tipo do Produto)")]
        Product_Post_BadRequest_ProductType_Cannot_Be_Null_Or_Empty,

        [Description("Necessário informar a propriedade (Categoria do Produto)")]
        Product_Post_BadRequest_ProductCategory_Cannot_Be_Null_Or_Empty,

        [Description("Necessário informar a propriedade (Unidade do Produto")]
        Product_Post_BadRequest_ProductUnity_Cannot_Be_Null_Or_Empty,

        [Description("Necessário informar a propriedade (Preço)")]
        Product_Post_BadRequest_Price_Cannot_Be_Null_Or_Empty,

        [Description("Necessário informar a propriedade (Porcentagem")]
        Product_Post_BadRequest_Percentage_Cannot_Be_Null_Or_Empty,


        #endregion
    }

}
