<?xml version="1.0"?>
<!-- Ersi Zha, Assignment 4 -->
<?xml-stylesheet type="text/xsl" href="Services.xsl"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Ersi Zha - Services</h1>6
        <table border = "2">
          <tr bgcolor="yellow">
            <td>
              <b>Name</b>
            </td>
            <td>
              <b>ServiceUrl and TryItUrl</b>
            </td>
            <td>
              <b>Provider</b>
            </td>
            <td>
              <b>Operations</b>
            </td>
            <td>
              <b>Category</b>
            </td>
          </tr>
          <xsl:for-each select="Services/Service">
            <tr style="font-size: 10pt; font-family: verdana">
              <td>
                <xsl:value-of select="Name"/>
              </td>
              <td>
                <br>
                  <xsl:value-of select="@ServiceUrl"/>
                </br>
                <br>
                  <xsl:value-of select="@TryItUrl"/>
                </br>
              </td>
              <td>
                <xsl:value-of select="Provider"/>
              </td>
              <td>
                <xsl:for-each select="Operations/Operation">
                  <i>
                    <xsl:text>Name:</xsl:text><xsl:value-of select="Name"/>&#160;
                    <xsl:text>MsgIn:</xsl:text><xsl:value-of select="MsgIn"/>&#160;
                    <xsl:text>MsgOut:</xsl:text><xsl:value-of select="MsgOut"/>&#160;
                  </i>
                </xsl:for-each>
              </td>
              <td>
                <xsl:value-of select="Category"/>
                <xsl:value-of select="@Platform"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
