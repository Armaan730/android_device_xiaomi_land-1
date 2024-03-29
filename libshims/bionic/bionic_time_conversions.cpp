#include "private/bionic_time_conversions.h"

#define NS_PER_S 1000000000

void absolute_timespec_from_timespec(timespec& abs_ts, const timespec& ts, clockid_t clock) {
  clock_gettime(clock, &abs_ts);
  abs_ts.tv_sec += ts.tv_sec;
  abs_ts.tv_nsec += ts.tv_nsec;
  if (abs_ts.tv_nsec >= NS_PER_S) {
    abs_ts.tv_nsec -= NS_PER_S;
    abs_ts.tv_sec++;
  }
}

bool timespec_from_absolute_timespec(timespec& ts, const timespec& abs_ts, clockid_t clock) {
  clock_gettime(clock, &ts);
  ts.tv_sec = abs_ts.tv_sec - ts.tv_sec;
  ts.tv_nsec = abs_ts.tv_nsec - ts.tv_nsec;
  if (ts.tv_nsec < 0) {
    ts.tv_sec--;
    ts.tv_nsec += NS_PER_S;
  }
  if (ts.tv_nsec < 0 || ts.tv_sec < 0) {
    return false;
  }
  return true;
}
