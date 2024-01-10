// Quantity: 5000
// Output: < h2 > Widgets & reg;</ h2 >< span > 5000 </ span >

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// int spanOpening = input.IndexOf("<span>");
// int spanClosing = input.IndexOf("</span>");
// int spanOffset = 6;

// int headerOpening = input.IndexOf("<h2>");
// int headerClosing = input.IndexOf("</h2>");
// int headerOffset = 4;

// string quantity = input.Substring(spanOpening + spanOffset, spanClosing - spanOpening - spanOffset);
// string output = input.Substring(headerOpening + headerOffset, headerClosing - headerOpening - headerOffset);
// output = output.Replace("&trade", "&reg");
// output += input.Substring(spanOpening, spanClosing - spanOpening + spanOffset + 1);

// Your work here

// Console.WriteLine($"Quantity: {quantity}");
// Console.WriteLine($"Output: {output}");

/* Learn Solution BELOW

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

*/