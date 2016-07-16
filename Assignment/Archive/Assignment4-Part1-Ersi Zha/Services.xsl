<?xml version="1.0"?>
<!-- Ersi Zha, Assignment 4 -->
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0"
		xmlns:fo="http://www.w3.org/1999/XSL/Format" 
		xmlns:xs="http://www.w3.org/2001/XMLSchema" 
		xmlns:fn="http://www.w3.org/2005/xpath-functions" 
		xmlns:xsi="./Services.xsd">
	<xsl:template match="/">
		<html><body>
		<h1>Ersi Zha - Services</h1>
		<table border = "2">
			<tr bgcolor="yellow"> 
				<td><b>Name</b></td> 
        <td><b>ServiceUrl and TryItUrl</b></td>
				<td><b>Provider</b></td> 
				<td><b>Operations</b></td> 
				<td><b>Category</b></td> 
			</tr>
			<xsl:for-each select="xsi:Services/xsi:Service">
				<tr style="font-size: 10pt; font-family: verdana">
					<td><xsl:value-of select="xsi:Name"/></td>
          <td>
            <br><xsl:value-of select="@ServiceUrl"/></br>
            <br><xsl:value-of select="@TryItUrl"/></br>
          </td>
					<td><xsl:value-of select="xsi:Provider"/></td>
					<td>
						<xsl:for-each select="xsi:Operations/xsi:Operation">
							<i>
                <xsl:text>Name:</xsl:text><xsl:value-of select="xsi:Name"/>&#160;
                <xsl:text>MsgIn:</xsl:text><xsl:value-of select="xsi:MsgIn"/>&#160;
                <xsl:text>MsgOut:</xsl:text><xsl:value-of select="xsi:MsgOut"/>&#160;
              </i>
						</xsl:for-each>
					</td>
					<td><xsl:value-of select="xsi:Category"/>
            <xsl:value-of select="@Platform"/>
          </td>
				</tr>
			</xsl:for-each>
		</table>
		</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
