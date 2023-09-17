# APITemplateio.Model.PDFGenerationSettingsObject
The settings object contains various properties to configure the PDF generation. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaperSize** | **string** | Specifies the paper size for the PDF. The available options are Letter, Legal, Tabloid, Ledger, A0, A1, A2, A3, A4, A5,A6 or custom. custom dimensions specified as \&quot;custom_width\&quot; and \&quot;custom_height\&quot;.  | [optional] 
**CustomWidth** | **string** | Custom width for the custom paper size. Valid units are mm, px and cm. eg: 30mm  | [optional] 
**CustomHeight** | **string** | Custom height for the custom paper size. Valid units are mm, px and cm. eg: 30mm  | [optional] 
**Orientation** | **string** | Specifies the orientation of the PDF. The available options are \&quot;1\&quot; for portrait and \&quot;2\&quot; for landscape.  | [optional] 
**HeaderFontSize** | **string** | Specifies the font size for the header in the PDF.  | [optional] 
**MarginTop** | **string** | Specify the top margin for the PDF in millimeters (mm).  | [optional] 
**MarginRight** | **string** | Specify the right margin for the PDF in millimeters (mm).  | [optional] 
**MarginBottom** | **string** | Specify the bottom margin for the PDF in millimeters (mm).  | [optional] 
**MarginLeft** | **string** | Specify the left margin for the PDF in millimeters (mm).  | [optional] 
**PrintBackground** | **string** | Specifies whether to print the background graphics and colors in the PDF. Set to \&quot;1\&quot; to include backgrounds or \&quot;0\&quot; to exclude them.  | [optional] 
**DisplayHeaderFooter** | **bool** | Specifies whether to display the header and footer in the PDF. Set to true to include the header and footer or false to exclude them.  | [optional] 
**CustomHeader** | **string** | Specify custom HTML markup for the headerof the PDF. These properties should contain valid HTML markup, including any necessary CSS styles.  | [optional] 
**CustomFooter** | **string** | Specify custom HTML markup for the footer of the PDF. These properties should contain valid HTML markup, including any necessary CSS styles.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

