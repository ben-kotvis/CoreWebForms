// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Web;

internal static class AssemblyRef
{
    public const string SystemDesign = nameof(SystemDesign);
    public const string MicrosoftVisualStudioWeb = nameof(MicrosoftVisualStudioWeb);
}

internal static class SR
{
    public static string GetString(string name, params object[] args) => name;
    
    public const string AutoPostBackControl_CausesValidation = nameof(AutoPostBackControl_CausesValidation);
    public const string Button_CausesValidation = nameof(Button_CausesValidation);
    public const string Button_OnClick = nameof(Button_OnClick);
    public const string Button_OnClientClick = nameof(Button_OnClientClick);
    public const string Button_OnCommand = nameof(Button_OnCommand);
    public const string Button_PostBackUrl = nameof(Button_PostBackUrl);
    public const string Button_Text = nameof(Button_Text);
    public const string Button_UseSubmitBehavior = nameof(Button_UseSubmitBehavior);
    public const string Cannot_exit_up_top_directory = nameof(Cannot_exit_up_top_directory);
    public const string Cannot_Have_Children_Of_Type = nameof(Cannot_Have_Children_Of_Type);
    public const string ClientScriptManager_InvalidPostBackArgument = nameof(ClientScriptManager_InvalidPostBackArgument);
    public const string ClientScriptManager_JqueryNotRegistered = nameof(ClientScriptManager_JqueryNotRegistered);
    public const string ClientScriptManager_RegisterForEventValidation_Too_Early = nameof(ClientScriptManager_RegisterForEventValidation_Too_Early);
    public const string Collection_readonly_Codeblocks = nameof(Collection_readonly_Codeblocks);
    public const string Control_ClientID = nameof(Control_ClientID);
    public const string Control_ClientIDMode = nameof(Control_ClientIDMode);
    public const string Control_Controls = nameof(Control_Controls);
    public const string Control_does_not_allow_children = nameof(Control_does_not_allow_children);
    public const string Control_EnableTheming = nameof(Control_EnableTheming);
    public const string Control_ID = nameof(Control_ID);
    public const string Control_MaintainState = nameof(Control_MaintainState);
    public const string Control_NamingContainer = nameof(Control_NamingContainer);
    public const string Control_NotADescendentOfNamingContainer = nameof(Control_NotADescendentOfNamingContainer);
    public const string Control_OnDataBind = nameof(Control_OnDataBind);
    public const string Control_OnDisposed = nameof(Control_OnDisposed);
    public const string Control_OnInit = nameof(Control_OnInit);
    public const string Control_OnLoad = nameof(Control_OnLoad);
    public const string Control_OnPreRender = nameof(Control_OnPreRender);
    public const string Control_OnUnload = nameof(Control_OnUnload);
    public const string Control_Page = nameof(Control_Page);
    public const string Control_Parent = nameof(Control_Parent);
    public const string Control_Site = nameof(Control_Site);
    public const string Control_SkinId = nameof(Control_SkinId);
    public const string Control_State = nameof(Control_State);
    public const string Control_TemplateControl = nameof(Control_TemplateControl);
    public const string Control_TemplateSourceDirectory = nameof(Control_TemplateSourceDirectory);
    public const string Control_UniqueID = nameof(Control_UniqueID);
    public const string Control_ValidateRequestMode = nameof(Control_ValidateRequestMode);
    public const string Control_ViewStateMode = nameof(Control_ViewStateMode);
    public const string Control_Visible = nameof(Control_Visible);
    public const string Controls_Cant_Change_Between_Posts = nameof(Controls_Cant_Change_Between_Posts);
    public const string Duplicate_id_used = nameof(Duplicate_id_used);
    public const string Empty_path_has_no_directory = nameof(Empty_path_has_no_directory);
    public const string FontInfo_Bold = nameof(FontInfo_Bold);
    public const string FontInfo_Italic = nameof(FontInfo_Italic);
    public const string FontInfo_Name = nameof(FontInfo_Name);
    public const string FontInfo_Names = nameof(FontInfo_Names);
    public const string FontInfo_Overline = nameof(FontInfo_Overline);
    public const string FontInfo_Size = nameof(FontInfo_Size);
    public const string FontInfo_Strikeout = nameof(FontInfo_Strikeout);
    public const string FontInfo_Underline = nameof(FontInfo_Underline);
    public const string HTMLTextWriterUnbalancedPop = nameof(HTMLTextWriterUnbalancedPop);
    public const string Invalid_app_VirtualPath = nameof(Invalid_app_VirtualPath);
    public const string Invalid_vpath = nameof(Invalid_vpath);
    public const string InvalidArgumentValue = nameof(InvalidArgumentValue);
    public const string InvalidOffsetOrCount = nameof(InvalidOffsetOrCount);
    public const string InvalidSerializedData = nameof(InvalidSerializedData);
    public const string Label_AssociatedControlID = nameof(Label_AssociatedControlID);
    public const string Label_Text = nameof(Label_Text);
    public const string LabelForNotFound = nameof(LabelForNotFound);
    public const string ListEnumCurrentOutOfRange = nameof(ListEnumCurrentOutOfRange);
    public const string ListEnumVersionMismatch = nameof(ListEnumVersionMismatch);
    public const string Literal_Mode = nameof(Literal_Mode);
    public const string Literal_Text = nameof(Literal_Text);
    public const string NoFocusSupport = nameof(NoFocusSupport);
    public const string Page_CallBackTargetInvalid = nameof(Page_CallBackTargetInvalid);
    public const string Parameter_NullOrEmpty = nameof(Parameter_NullOrEmpty);
    public const string Parent_collections_readonly = nameof(Parent_collections_readonly);
    public const string Path_must_be_rooted = nameof(Path_must_be_rooted);
    public const string PersonalizationProviderHelper_TrimmedEmptyString = nameof(PersonalizationProviderHelper_TrimmedEmptyString);
    public const string Physical_path_not_allowed = nameof(Physical_path_not_allowed);
    public const string PostBackControl_ValidationGroup = nameof(PostBackControl_ValidationGroup);
    public const string PropertySetBeforePreInitOrAddToControls = nameof(PropertySetBeforePreInitOrAddToControls);
    public const string PropertySetBeforeStyleSheetApplied = nameof(PropertySetBeforeStyleSheetApplied);
    public const string StateManagedCollection_InvalidIndex = nameof(StateManagedCollection_InvalidIndex);
    public const string StateManagedCollection_NoKnownTypes = nameof(StateManagedCollection_NoKnownTypes);
    public const string StringUtil_Trimmed_String_Exceed_Maximum_Length = nameof(StringUtil_Trimmed_String_Exceed_Maximum_Length);
    public const string Style_BackColor = nameof(Style_BackColor);
    public const string Style_BorderColor = nameof(Style_BorderColor);
    public const string Style_BorderStyle = nameof(Style_BorderStyle);
    public const string Style_BorderWidth = nameof(Style_BorderWidth);
    public const string Style_CSSClass = nameof(Style_CSSClass);
    public const string Style_Font = nameof(Style_Font);
    public const string Style_ForeColor = nameof(Style_ForeColor);
    public const string Style_Height = nameof(Style_Height);
    public const string Style_InvalidBorderWidth = nameof(Style_InvalidBorderWidth);
    public const string Style_InvalidHeight = nameof(Style_InvalidHeight);
    public const string Style_InvalidWidth = nameof(Style_InvalidWidth);
    public const string Style_RegisteredStylesAreReadOnly = nameof(Style_RegisteredStylesAreReadOnly);
    public const string Style_Width = nameof(Style_Width);
    public const string StyleSheetAreadyAppliedOnControl = nameof(StyleSheetAreadyAppliedOnControl);
    public const string Substitution_NotAllowed = nameof(Substitution_NotAllowed);
    public const string Substitution_SiteNotAllowed = nameof(Substitution_SiteNotAllowed);
    public const string TextBox_AutoCompleteType = nameof(TextBox_AutoCompleteType);
    public const string TextBox_AutoPostBack = nameof(TextBox_AutoPostBack);
    public const string TextBox_Columns = nameof(TextBox_Columns);
    public const string TextBox_InvalidColumns = nameof(TextBox_InvalidColumns);
    public const string TextBox_InvalidRows = nameof(TextBox_InvalidRows);
    public const string TextBox_MaxLength = nameof(TextBox_MaxLength);
    public const string TextBox_OnTextChanged = nameof(TextBox_OnTextChanged);
    public const string TextBox_ReadOnly = nameof(TextBox_ReadOnly);
    public const string TextBox_Rows = nameof(TextBox_Rows);
    public const string TextBox_Text = nameof(TextBox_Text);
    public const string TextBox_TextMode = nameof(TextBox_TextMode);
    public const string TextBox_Wrap = nameof(TextBox_Wrap);
    public const string Type_not_creatable_from_string = nameof(Type_not_creatable_from_string);
    public const string UnitParseNoDigits = nameof(UnitParseNoDigits);
    public const string UnitParseNumericPart = nameof(UnitParseNumericPart);
    public const string ViewState_InvalidViewState = nameof(ViewState_InvalidViewState);
    public const string VirtualPath_Length_Zero = nameof(VirtualPath_Length_Zero);
    public const string WebControl_CommandArgument = nameof(WebControl_CommandArgument);
    public const string WebControl_CommandName = nameof(WebControl_CommandName);
}
