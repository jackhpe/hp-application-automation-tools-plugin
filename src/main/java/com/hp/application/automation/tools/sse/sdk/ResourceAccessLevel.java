package com.hp.application.automation.tools.sse.sdk;

import com.hp.application.automation.tools.rest.RESTConstants;

public enum ResourceAccessLevel {
    PUBLIC(null), PROTECTED(RESTConstants.PtaL), PRIVATE(RESTConstants.PvaL);
    
    private String _headerName;
    
    private ResourceAccessLevel(String headerName) {
        
        _headerName = headerName;
    }
    
    public String getUserHeaderName() {
        
        return _headerName;
    }
}
