Original spec: https://www.monodevelop.com/developers/articles/color-scheme-definition/
**Example JSON**
``` JSON
{
	"name": "ThemeName",
	"version": "1.0",
	"description": "A description",
	"originator": "Author Details",

	"palette": [
		{ "name": "color-name", "value": "#RRGGBB | HSL" }
  ],
  
  "colors": [
		{ "name": "Color Token", "color": "color-name | #RRGGBB", "secondcolor": "color-name | #RRGGBB" }
  ]
  
  "text": [
		{ "name": "Text Token",
		"fore": "color-name | #RRGGBB", 
		"back": "color-name | #RRGGBB", 
		"weight": "ultrathin | thin | ultralight | light | semilight | book | normal | medium | mediumbold | semibold | bold | ultrabold | heavy | ultraheavy | semiblack | black | ultrablack" ,
		"style": "normal | oblique | italic"
		}
  }
}
```

**Color tokens**
* Background(Read Only)
* Search result background
* Search result background (highlighted)
* Fold Square
* Fold Cross
* Indentation Guide
* Indicator Margin
* Indicator Margin(Separator)
* Tooltip Pager Top
* Tooltip Pager Triangle
* Tooltip Pager Text
* Notification Border
* Bookmarks
* Underline(Error)
* Underline(Warning)
* Underline(Suggestion)
* Underline(Hint)
* Quick Diff(Dirty)
* Quick Diff(Changed)
* Brace Matching(Rectangle)
* Usages(Rectangle)
* Changing usages(Rectangle)
* Breakpoint Marker
* Breakpoint Marker(Invalid)
* Breakpoint Marker(Disabled)
* Debugger Current Line Marker
* Debugger Stack Line Marker
* Primary Link
* Primary Link(Highlighted)
* Secondary Link
* Secondary Link(Highlighted)
* Current Line Marker
* Current Line Marker(Inactive)
* Column Ruler
* Completion Window
* Completion Tooltip Window
* Completion Selection Bar Border
* Completion Selection Bar Background
* Completion Selection Bar Border(Inactive)
* Completion Selection Bar Background(Inactive)
* Message Bubble Error Marker
* Message Bubble Error Tag
* Message Bubble Error Tooltip
* Message Bubble Error Line
* Message Bubble Error Counter
* Message Bubble Error IconMargin
* Message Bubble Warning Marker
* Message Bubble Warning Tag
* Message Bubble Warning Tooltip
* Message Bubble Warning Line
* Message Bubble Warning Counter
* Message Bubble Warning IconMargin
* Link Color
* Link Color(Active)
	    
**Text tokens**
* Plain Text
* Selected Text
* Selected Text(Inactive)
* Collapsed Text
* Line Numbers
* Punctuation
* Punctuation(Brackets)
* Comment(Line)
* Comment(Block)
* Comment(Doc)
* Comment(DocTag)
* Comment Tag
* Excluded Code
* String
* String(Escape)
* String(C# @ Verbatim)
* Number
* Preprocessor
* Preprocessor(Region Name)
* Xml Text
* Xml Delimiter
* Xml Name
* Xml Attribute
* Xml Attribute Quotes
* Xml Attribute Value
* Xml Comment
* Xml CData Section
* Tooltip Text
* Notification Text
* Completion Text
* Completion Matching Substring
* Completion Selected Text
* Completion Selected Matching Substring
* Completion Selected Text(Inactive)
* Completion Selected Matching Substring(Inactive)
* Keyword(Access)
* Keyword(Type)
* Keyword(Operator)
* Keyword(Selection)
* Keyword(Iteration)
* Keyword(Jump)
* Keyword(Context)
* keyword - control
* Keyword(Exception)
* Keyword(Modifiers)
* Keyword(Constants)
* Keyword(Void)
* Keyword(Namespace)
* Keyword(Property)
* Keyword(Declaration)
* Keyword(Parameter)
* Keyword(Operator Declaration)
* Keyword(Other)
* User Types
* User Types(Enums)
* User Types(Interfaces)
* User Types(Delegates)
* User Types(Value types)
* User Types(Type parameters)
* User Types(Mutable)
* User Field Usage
* User Field Declaration
* User Property Usage
* User Property Declaration
* User Event Usage
* User Event Declaration
* User Method Usage
* User Method Declaration
* User Parameter Usage
* User Parameter Declaration
* User Variable Usage
* User Variable Declaration
* Syntax Error
* String Format Items
* Breakpoint Text
* Debugger Current Statement
* Debugger Stack Line
* Diff Line(Added)
* Diff Line(Removed)
* Diff Line(Changed)
* Diff Header
* Diff Header(Separator)
* Diff Header(Old)
* Diff Header(New)
* Diff Location
* Preview Diff Removed Line
* Preview Diff Added Line
* Html Attribute Name
* Html Attribute Value
* Html Comment
* Html Element Name
* Html Entity
* Html Operator
* Html Server-Side Script
* Html Tag Delimiter
* Razor Code
* Css Comment
* Css Property Name
* Css Property Value
* Css Selector
* Css String Value
* Css Keyword
* Script Comment
* Script Identifier
* Script Keyword
* Script Number
* Script Operator
* Script String
* String(Regex Alternation)
* String(Regex Alt Escape Character)
* String(Regex Anchor)
* String(Regex Text)
* String(Regex Set Constructs)
* String(Regex Character Class)
* String(Regex Comments)
* String(Regex Grouping Constructs)
* String(Regex Escape Character)
* String(Regex Self Escaped Character)
* String(Regex Quantifier)
* XAML Attribute
* XAML Attribute Value
* XAML CData Section
* XAML Comment
* XAML Delimiter
* XAML Markup Extension Class
* XAML Markup Extension Parameter Name
* XAML Markup Extension Parameter Value
* XAML Name
* extension method name
* Xaml Text
* Xaml Attribute Quotes
* operator - overloaded
