import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiHandlerService } from 'src/app/core/shared/utils/api-handler.service';
import { API_ENDPOINTS, ApiMethod,API_URL } from 'src/app/core/shared/utils/const';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  constructor(
    // private http: ApiHandlerService,
    private http: HttpClient) {}
    private headers = new HttpHeaders({
      'Access-Control-Allow-Origin': '*',
      'content-type': 'application/json'
    });

  getDepartments() {
    return this.http.get(`${API_URL}${API_ENDPOINTS.getDepartments}`,{ headers : this.headers });
  }
  getDepartmentById(id: any) {
    return this.http.get(`${API_URL}${API_ENDPOINTS.getDepartmentById}?id=${id}`,{ headers : this.headers });
  }

  createDepartment(data: any) {
    return this.http.post(`${API_URL}${API_ENDPOINTS.createDepartment}`, data,{ headers : this.headers });
  }

  updateDepartment(data: any) {
    return this.http.put(`${API_URL}${API_ENDPOINTS.updateDepartment}`, data,{ headers : this.headers });
  }

  deleteDepartment(id: any) {
    return this.http.delete(`${API_URL}${API_ENDPOINTS.deleteDepartment}?id=${id}`,{ headers : this.headers });
  }
}
