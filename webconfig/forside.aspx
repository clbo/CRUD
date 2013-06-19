<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forside.aspx.cs" Inherits="forside" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Hello web.config</title>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet" type="text/css" />
    <link href="bootstrap/css/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="hero-unit">
            <h1>
                Hello web.config</h1>
            <p class="lead">
                Et simpelt sample site til brug ved opgaveløsning og demonstration</p>
            <p>
                Du har fået gennemgået opgaverne herunder ved tavlen.</p>
            <p>
                Din opgave er nu at lave dit eget simple website hvor du i web.config filen skriver
                løsningen på opgaverne.</p>
            <p class="lead">
                Opgaverne er løst når:</p>
            <ol>
              <li>du har lagt sitet online på dit webhotel og ændringerne i din web.config fil virker. </li>
              <li>og du har  afleveret selve web.config filen  og et link til din web.config opgave på Fronter.</li>
            </ol>
            <p>
                Med mindre du kan huske alt hvad der er blevet gennemgået ved tavlen, er du nød
                til at Google dig frem løsningen af opgaverne.</p>
            <p class="alert">
                Under hvert spørgsmål er der derfor skrevet nogle forslag til søgeord i en boks
                som denne.</p>
        </div>
        <section class="hero-unit" id="1">
            <h2>
                1. Bestem navnet på din egen index side</h2>
            <p>
                I web.config filen kan du bestemme hvilken side der skal bruges som din defaultside
                (altså den der normalt hedder Default.aspx).</p>
            <p>
                Ofte er IIS serveren sat op til at bruge netop Default.aspx, men du kan selv definere
                hvilken side på dit site der skal bruges som defaultside.</p>
            <p>
                Eksempel: På dette site er der ingen <a href="Default.aspx">Default.aspx</a> (prøv
                selv), men derimod en <a href="forside.aspx">forside.aspx</a>, og i web.config filen
                er forside.aspx sat til at være indexsiden.</p>
            <p class="lead">
                Opgave: Find ud af hvad du skal skrive i web.config filen for at gøre forside.aspx
                til din defaultsside</p>
            <p class="alert">
                Søgeord: web.config, default index page, indexside</p>
        </section>
        <div class="hero-unit" id="2">
            <h2>
                2. Directory listing</h2>
            <p>
                Ofte er serveren sat op til <u>ikke</u> at vise en <a href="myPictures">liste</a>
                over filer i en mappe.</p>
            <p>
                Dette kan du overskrive og derved få vist listen, hvis du vel og mærke ikke har
                en Default.aspx side (eller hvad du har valgt som defaultside) i din mappe</p>
            <p class="lead">
                Opgave: Find ud af hvad man skal skrive i web.config filen for at opnå dette.</p>
            <p class="alert">
                Søgeord: web.config mappe listning, directory index</p>
        </div>
        <div class="hero-unit" id="3">
            <h2>
                3. Fejlsider</h2>
            <p>
                Hvis du forsøger at browse til en side der ikke eksisterer på et website vil du
                se en side der fortæller at siden ikke eksisterer og at der er en fejlkode 404</p>
            <p>
                Du kan lave dine egene, smukkere designede fejlsider og i web.config filen definerer
                at netop disse sider skal vises i tælfælde af en bestemt fejl.</p>
            <p>
                De mest almindelige fejl er:</p>
            <ul>
                <li>403 - du har ikke rettighed til at se denne side</li>
                <li>404 - siden findes ikke - <a href="sidederikkeeksisterer.aspx">eksempel</a></li>
                <li>500 - intern server fejl</li>
            </ul>
            <p class="lead">
                Opgave: Lav din egen 404 fejlside og få den vist i stedet for den normale server
                404 fejlside</p>
            <p class="alert">
                Søgeord: web.config fejlsider, errorpages</p>
        </div>
        <section class="hero-unit" id="4">
            <h2>
                4. Redirect</h2>
            <p>
                En måde at viderestille fra en side til en anden er ved at definerer det i web.config
                filen.</p>
            <p class="lead">
                Opgave: Find ud af hvordan dette gøres.</p>
            <p>
                Eksempel: <a href="minebilleder">Dette er et link til mappen /minebilleder/ men den
                    redirectes til mappen myPictures</a></p>
            <p class="alert">
                Søgeord: web.config redirect</p>
        </section>
        <%-- <div class="hero-unit" id="5">
            <h2>
                5. Bloker eller tillad brugere fra en bestemt ip</h2>
            <p>
                Brugere kan blokeres eller tillades adgang på deres ip adresse.</p>
            <p>
                Dette er f.eks brugbart hvis man kun skal have adgang til bestemte sider hvis man
                er på en bestemt ip adresse. Eksempelvis et Intranet.</p>
            <p class="lead">
                Opgave: Find ud af hvordan dette gøres.</p>
            <p class="alert">
                Søgeord: web.config block on ip address, bloker en ipadresse</p>
        </div>--%>
        <div class="hero-unit" id="6">
            <h2>
                5. Fil størrelse der kan uploades</h2>
            <p>
                Ofte er der på en IIS server en begrænsning for at uploade filer med en
                størrelse på 2MB</p>
            <p>
                Tit har man dog sbrug for at uploade filer som er større.</p>
            <p class="lead">
                Opgave: Find ud af hvordan denne max file size ændre gennem web.config filen.</p>
            <p class="alert">
                Søgeord: web.config max file size, fil størrelse upload</p>
        </div>
        <%--<div class="hero-unit" id="7">
            <h2>
                7. Password</h2>
            <p>
                En relativ sikker måde at beskytte dele af sit website på kan ske gennem web.config
                filen og en tilhørende .htpassword fil.</p>
            <ul>
                <li>web.config</li>
                <li>.htpassword</li>
            </ul>
            <p>
                Eksempel: <a href="password/index.php">Link til passwordbeskyttet mappe</a> (User:admin,
                pass:1234)</p>
            <p class="lead">
                Opgave: Find ud af hvordan dette laves</p>
            <p class="alert">
                Søgeord: web.config password, kodeord</p>
        </div>--%>
        <div class="hero-unit" id="8">
            <h2>
                6. Egne løsninger</h2>
            <p class="lead">
                Opgave: Find selv 1, 2 eller 3 web.config elementer som du vil implementere på dit
                site</p>
            <p>
                Eksempler kunne være</p>
            <ul>
                <li>Caching</li>
                <li>SMTP mail settings</li>
                <li>Session time out</li>
            </ul>
            <p class="alert">
                Søgeord: web.config tips & tricks</p>
        </div>
        <footer class="modal-footer">
RTS - Webserver (Dag 5) 12-03-2013 - clb</footer>
    </div>
    <script src="bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>
    </form>
</body>
</html>
