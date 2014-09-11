Practice 3: Web Page Reader (Advanced)
======================================

This is yet another console application.

When the application starts, the user is asked to enter a URI for a web page.

You might enter something like: *http://www.microsoft.com*

Then it asks your for a filename. You might enter something like: *c:\practices\microsoft"*

Your application starts a StopWatch, then the application makes an HTTP request to that URI, downloads the content, the stops the StopWatch. The content downloaded from the URI is saved to the filename you entered, with a ".html" extension added (so, for our example *c:\practices\microsoft.html*.)

On the display show how many total bytes were downloaded and the time in minutes, seconds, and milliseconds that it took to download the file.

