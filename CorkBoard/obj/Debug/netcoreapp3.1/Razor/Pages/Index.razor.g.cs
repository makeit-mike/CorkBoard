#pragma checksum "C:\Users\mikei\source\repos\CorkBoard\CorkBoard\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca1b8879b02409f9ab0b9baf5ecb1aaf3cdcc9c6"
// <auto-generated/>
#pragma warning disable 1591
namespace CorkBoard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mikei\source\repos\CorkBoard\CorkBoard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mikei\source\repos\CorkBoard\CorkBoard\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikei\source\repos\CorkBoard\CorkBoard\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mikei\source\repos\CorkBoard\CorkBoard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mikei\source\repos\CorkBoard\CorkBoard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mikei\source\repos\CorkBoard\CorkBoard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mikei\source\repos\CorkBoard\CorkBoard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mikei\source\repos\CorkBoard\CorkBoard\_Imports.razor"
using CorkBoard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mikei\source\repos\CorkBoard\CorkBoard\_Imports.razor"
using CorkBoard.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"index\">\r\n        \r\n        <section class=\"board-info-bar\">\r\n\r\n            <div class=\"board-controls\">\r\n\r\n                <button class=\"board-title btn\">\r\n                    <h2>Web Development</h2>\r\n                </button>\r\n\r\n\r\n                <button class=\"personal-btn btn\">Personal</button>\r\n\r\n                <button class=\"private-btn btn\"><i class=\"fas fa-briefcase private-btn-icon\" aria-hidden=\"true\"></i>Private</button>\r\n\r\n            </div>\r\n\r\n            <button class=\"menu-btn btn\"><i class=\"fas fa-ellipsis-h menu-btn-icon\" aria-hidden=\"true\"></i>Show Menu</button>\r\n\r\n        </section>\r\n        \r\n        \r\n        <section class=\"lists-container\" style=\"max-width:100%;\">\r\n\r\n            <div class=\"list\">\r\n\r\n                <h3 class=\"list-title\">Tasks to Do</h3>\r\n\r\n                <ul class=\"list-items\">\r\n                    <li>Figure out width issue on navbar/linkheader</li>\r\n                    <li>Convert hardcoded lists into foreach loops</li>\r\n                    <li>Add click events for dyanmic rows</li>\r\n                    <li>set up MySql</li>\r\n                    <li>store array list data in sql</li>\r\n                    <li>Add edit icon</li>\r\n                    <li>Add Delete icon</li>\r\n\r\n                </ul>\r\n\r\n                <button class=\"add-card-btn btn\">Add a card</button>\r\n\r\n            </div>\r\n\r\n            <div class=\"list\">\r\n\r\n                <h3 class=\"list-title\">Completed Tasks</h3>\r\n\r\n                <ul class=\"list-items\">\r\n                    <li>Clear email inbox</li>\r\n                    <li>Finalise requirements for client web design</li>\r\n                    <li>Begin work on mock-up for client website</li>\r\n                </ul>\r\n\r\n                <button class=\"add-card-btn btn\">Add a card</button>\r\n\r\n            </div>\r\n\r\n            <div class=\"list\">\r\n\r\n                <h3 class=\"list-title\">Topics/Concepts to Revise</h3>\r\n\r\n                <ul class=\"list-items\">\r\n                    <li>HTML Elements</li>\r\n                    <li>HTML Form Validation</li>\r\n                    <li>HTML Structured Data</li>\r\n                    <li>Advanced CSS Selectors</li>\r\n                    <li>CSS Transforms</li>\r\n                    <li>CSS Animations</li>\r\n                    <li>CSS Flexbox</li>\r\n                    <li>CSS Grid</li>\r\n                    <li>CSS Methodologies (BEM, SMACSS etc.)</li>\r\n                    <li>SASS/SCSS</li>\r\n                    <li>Layout Fallbacks</li>\r\n                    <li>Responsive Design</li>\r\n                    <li>Design Patterns</li>\r\n                    <li>JavaScript Fundamentals</li>\r\n                    <li>JavaScript OOP</li>\r\n                    <li>JavaScript DOM Manipulation</li>\r\n                    <li>JavaScript Debugging Techniques</li>\r\n                    <li>Node Package Manager</li>\r\n                    <li>Grunt/Gulp</li>\r\n                    <li>GitHub</li>\r\n                    <li>Git Commands</li>\r\n                    <li>Web Accessibility</li>\r\n                    <li>Web Performance</li>\r\n                    <li>Web Hosting</li>\r\n                    <li>Browser Dev Tools</li>\r\n                    <li>Google Analytics</li>\r\n                    <li>Basic Photoshop/Sketch Usage</li>\r\n                </ul>\r\n\r\n                <button class=\"add-card-btn btn\">Add a card</button>\r\n\r\n            </div>\r\n\r\n            <div class=\"list\">\r\n\r\n                <h3 class=\"list-title\">Topics/Concepts to Learn</h3>\r\n\r\n                <ul class=\"list-items\">\r\n                    <li>HTML 5.2 New Features</li>\r\n                    <li>Responsive Images (picture element, srcset/sizes etc.)</li>\r\n                    <li>Serverless</li>\r\n                    <li>Variable Fonts</li>\r\n                    <li>Shadow DOM</li>\r\n                    <li>ES6+</li>\r\n                    <li>JSON & AJAX</li>\r\n                    <li>API\'s</li>\r\n                    <li>JavaScript Patterns</li>\r\n                    <li>JavaScript Testing</li>\r\n                    <li>jQuery</li>\r\n                    <li>SVG</li>\r\n                    <li>React JS</li>\r\n                    <li>Angular JS</li>\r\n                    <li>TypeScript</li>\r\n                    <li>Vue JS</li>\r\n                    <li>Node JS</li>\r\n                    <li>Webpack</li>\r\n                    <li>SEO Techniques</li>\r\n                    <li>HTML Emails</li>\r\n                    <li>WordPress</li>\r\n                    <li>Static Site Generators (Jekyll, Hugo, Gatsby etc.)</li>\r\n                </ul>\r\n\r\n                <button class=\"add-card-btn btn\">Add a card</button>\r\n\r\n            </div>\r\n\r\n            <div class=\"list\">\r\n\r\n                <h3 class=\"list-title\">Useful Websites for Learning</h3>\r\n\r\n                <ul class=\"list-items\">\r\n                    <li>Code Academy</li>\r\n                    <li>CodePen</li>\r\n                    <li>Codrops</li>\r\n                    <li>CSS-Tricks</li>\r\n                    <li>Free Code Camp</li>\r\n                    <li>Khan Academy</li>\r\n                    <li>Lynda</li>\r\n                    <li>Medium</li>\r\n                    <li>Mozilla Developer Network</li>\r\n                    <li>Stack Overflow</li>\r\n                    <li>Team Treehouse</li>\r\n                    <li>Tuts Plus</li>\r\n                    <li>Udemy</li>\r\n                    <li>WPSessions</li>\r\n                    <li>YouTube</li>\r\n                </ul>\r\n\r\n                <button class=\"add-card-btn btn\">Add a card</button>\r\n\r\n            </div>\r\n\r\n            <div class=\"list\">\r\n\r\n                <h3 class=\"list-title\">Web Dev YouTube Channels</h3>\r\n\r\n                <ul class=\"list-items\">\r\n                    <li>Adam Khoury</li>\r\n                    <li>Brad Hussey</li>\r\n                    <li>CSS-Tricks (Chris Coyier)</li>\r\n                    <li>Derek Banas</li>\r\n                    <li>DevTips (Travis Neilson)</li>\r\n                    <li>Free Code Camp</li>\r\n                    <li>Fun Fun Function (Mattias Petter Johansson)</li>\r\n                    <li>Google Chrome Developers</li>\r\n                    <li>Layout Land (Jen Simmons)</li>\r\n                    <li>Learn Code Academy</li>\r\n                    <li>Level Up Tuts (Scott Tolinski)</li>\r\n                    <li>Mackenzie Child</li>\r\n                    <li>Rachel Andrew</li>\r\n                    <li>The Net Ninja (Shaun Pelling)</li>\r\n                    <li>The New Boston (Bucky Roberts)</li>\r\n                    <li>Traversy Media (Brad Traversy)</li>\r\n                    <li>Wes Bos</li>\r\n                </ul>\r\n\r\n                <button class=\"add-card-btn btn\">Add a card</button>\r\n\r\n            </div>\r\n\r\n            <div class=\"list\">\r\n\r\n                <h3 class=\"list-title\">CodePen Ideas</h3>\r\n\r\n                <ul class=\"list-items\">\r\n                    <li>Something cool with CSS Grid</li>\r\n                    <li>Something cool with CSS Flexbox</li>\r\n                    <li>Something cool with CSS animations</li>\r\n                    <li>Something cool with CSS gradients</li>\r\n                    <li>Something cool with CSS pseudo-elements</li>\r\n                    <li>Something cool with SVG</li>\r\n                    <li>Something cool with JavaScript</li>\r\n                    <li>Something cool with all of the above</li>\r\n                </ul>\r\n\r\n                <button class=\"add-card-btn btn\">Add a card</button>\r\n\r\n            </div>\r\n\r\n            <div class=\"list\">\r\n\r\n                <h3 class=\"list-title\">Practise Website Ideas</h3>\r\n\r\n                <ul class=\"list-items\">\r\n                    <li>Airsoft/Paintballing Centre</li>\r\n                    <li>Bar/Pub</li>\r\n                    <li>Bicycle Shop/Repair</li>\r\n                    <li>Cafe/Coffee Shop</li>\r\n                    <li>Car Showroom/Garage/Repair/Parts</li>\r\n                    <li>Construction Company</li>\r\n                    <li>Fitness/Gym/Leisure Centre</li>\r\n                    <li>Nightclub</li>\r\n                    <li>Party Planning Company</li>\r\n                    <li>PC Build/Repair Service</li>\r\n                    <li>Portfolio/CV</li>\r\n                    <li>Real Estate/AirBnB</li>\r\n                    <li>Restaurant</li>\r\n                    <li>Skiing/Snowboarding Centre/Company</li>\r\n                    <li>Streaming Service for Movies/TV</li>\r\n                    <li>Streaming Service for Video Games</li>\r\n                    <li>Taxi Service</li>\r\n                    <li>Travel Agency</li>\r\n                    <li>Zoo/Safari Park</li>\r\n                </ul>\r\n\r\n                <button class=\"add-card-btn btn\">Add a card</button>\r\n\r\n            </div>\r\n\r\n            <div class=\"list\">\r\n\r\n                <h3 class=\"list-title\">JavaScript Project Ideas</h3>\r\n\r\n                <ul class=\"list-items\">\r\n                    <li>Analog Clock</li>\r\n                    <li>Basic Quiz</li>\r\n                    <li>Bill/Cost Splitter</li>\r\n                    <li>Countdown Timer</li>\r\n                    <li>Form Validator</li>\r\n                    <li>Geolocation (Find places near you etc.)</li>\r\n                    <li>Gif Search</li>\r\n                    <li>Note Taking App</li>\r\n                    <li>Random Name Picker</li>\r\n                    <li>Secret Message Encoder/Decoder</li>\r\n                    <li>Sortable Image Gallery</li>\r\n                    <li>Sortable Table</li>\r\n                    <li>Tip Calculator</li>\r\n                    <li>To-Do List</li>\r\n                    <li>Unit Converter</li>\r\n                </ul>\r\n\r\n                <button class=\"add-card-btn btn\">Add a card</button>\r\n\r\n            </div>\r\n\r\n            <button class=\"add-list-btn btn\">Add a list</button>\r\n            <div class=\"profile-pic\">\r\n                <img src=\"https://c1.staticflickr.com/5/4023/5154094149_8c1345f634.jpg\">\r\n                <div class=\"edit\"><a href=\"#\"><i class=\"fa fa-pencil fa-lg\"></i></a></div>\r\n            </div>\r\n        </section>\r\n        \r\n    </div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
