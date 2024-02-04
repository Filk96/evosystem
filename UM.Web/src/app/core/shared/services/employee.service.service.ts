import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiHandlerService } from 'src/app/core/shared/utils/api-handler.service';
import { API_ENDPOINTS, ApiMethod,API_URL } from 'src/app/core/shared/utils/const';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  constructor(
    // private http: ApiHandlerService,
    private http: HttpClient) {}
    private headers = new HttpHeaders({
      'Access-Control-Allow-Origin': '*',
      'content-type': 'application/json'
    });

  getEmployees() {
    return this.http.get(`${API_URL}${API_ENDPOINTS.getEmployee}`,{ headers : this.headers });
  }
  getEmployeetById(id: any) {
    return this.http.get(`${API_URL}${API_ENDPOINTS.getEmployeeById}?id=${id}`,{ headers : this.headers });
  }

  createEmployee(data: any) {
    return this.http.post(`${API_URL}${API_ENDPOINTS.createEmployee}`, data,{ headers : this.headers });
  }

  updateEmployee(data: any) {
    return this.http.put(`${API_URL}${API_ENDPOINTS.updateEmployee}`, data,{ headers : this.headers });
  }

  deleteEmployee(id: any) {
    return this.http.delete(`${API_URL}${API_ENDPOINTS.deleteEmployee}?id=${id}`,{ headers : this.headers });
  }
}
