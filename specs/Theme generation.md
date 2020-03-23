**Example JSON**
``` JSON
{
	"name": "ThemeName",
	"version": "1.0",
	"description": "A description",
	"originator": "Author Details",

	"palette": [
		{ "name": "color-name", "value": "#RRGGBB" }
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
Background(Read Only)
Search result background
Search result background (highlighted)
Fold Square
Fold Cross
            Indentation Guide
            Indicator Margin
            Indicator Margin(Separator)
            Tooltip Pager Top
            Tooltip Pager Triangle
            Tooltip Pager Text
            Notification Border
            Bookmarks
            Underline(Error)
            Underline(Warning)
            Underline(Suggestion)
            Underline(Hint)
            Quick Diff(Dirty)
            Quick Diff(Changed)
            Brace Matching(Rectangle)
            Usages(Rectangle)
            Changing usages(Rectangle)
            Breakpoint Marker
            Breakpoint Marker(Invalid)
            Breakpoint Marker(Disabled)
            Debugger Current Line Marker
            Debugger Stack Line Marker
            Primary Link
            Primary Link(Highlighted)
            Secondary Link
            Secondary Link(Highlighted)
            Current Line Marker
            Current Line Marker(Inactive)
            Column Ruler
            Completion Window
            Completion Tooltip Window
            Completion Selection Bar Border
            Completion Selection Bar Background
            Completion Selection Bar Border(Inactive)
            Completion Selection Bar Background(Inactive)
            Message Bubble Error Marker
            Message Bubble Error Tag
            Message Bubble Error Tooltip
            Message Bubble Error Line
            Message Bubble Error Counter
            Message Bubble Error IconMargin
            Message Bubble Warning Marker
            Message Bubble Warning Tag
            Message Bubble Warning Tooltip
            Message Bubble Warning Line
            Message Bubble Warning Counter
            Message Bubble Warning IconMargin
            Link Color
            Link Color(Active)
	    
**Text tokens**
