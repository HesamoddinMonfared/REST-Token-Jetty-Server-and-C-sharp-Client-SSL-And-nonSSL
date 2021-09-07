import javax.servlet.*;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.util.Enumeration;

public class myCustomFilter implements Filter {
    @Override
    public void doFilter(ServletRequest request, ServletResponse response, FilterChain chain)
            throws IOException, ServletException {

        HttpServletRequest httpRequest = (HttpServletRequest) request;
        String securityToken = httpRequest.getHeader("securityToken");
        System.out.print("Client Token is: " + securityToken);
        if(securityToken.equals("125")){
            chain.doFilter(request, response);
        }
        else{
            ((HttpServletResponse) response).sendError(HttpServletResponse.SC_FORBIDDEN);
        }


    }

    @Override
    public void init(FilterConfig arg0) throws ServletException {

    }

    @Override
    public void destroy() {}
}